 /** * */package microwave;import static org.junit.Assert.*;

import static org.junit.Assume.*;import java.util.ArrayList;

import java.util.Arrays;import static org.hamcrest.Matchers.*;

import org.junit.Before;import org.junit.runner.RunWith;

import com.pholser.junit.quickcheck.From;

import com.pholser.junit.quickcheck.Property;

import com.pholser.junit.quickcheck.generator.InRange;

import com.pholser.junit.quickcheck.generator.Size;

import com.pholser.junit.quickcheck.runner.JUnitQuickcheck;

/** * @author whalen * */

@RunWith(JUnitQuickcheck.class)

public class TestMicrowave {    public Microwave microwave;  

  @Before    public void setUp() {        ArrayList<Preset> presets = new ArrayList<Preset>();   

     presets.add(new Preset("Popcorn", 60, 10));     

   presets.add(new Preset("Pizza 1 slice", 55, 6));    

    presets.add(new Preset("Pizza 2 slice", 100, 6));       

 presets.add(new Preset("Chicken breast", 40, 7));       

 presets.add(new Preset("Defrost 1 lb hamburger", 180, 5));     

   microwave = new Microwave(new ModeController(), new DisplayController(1), presets);   

 }   

 public String digitsString(byte [] digits) {  

      return "" +                digits[DisplayController.TENS_OF_MINUTES] +   

             digits[DisplayController.MINUTES] +         

       digits[DisplayController.TENS_OF_SECONDS] +      

          digits[DisplayController.SECONDS];    }  

  /** seconds_elapse     *     * This method allows 'time' seconds to elapse with the microwave.     *  

   * @param time     * @throws Throwable     */  


  public void secondsElapse(int time)  {    

    // System.out.println("" + time + " seconds elapse.");   

     for (int i = 0; i < time*microwave.getTickRateInHz(); i++) {    

        microwave.tick();        }    }  


  public int calcTime(byte [] digits) {    

    return digits[DisplayController.TENS_OF_MINUTES] * 600 +            

    digits[DisplayController.MINUTES] * 60 +             

   digits[DisplayController.TENS_OF_SECONDS] * 10 +         

       digits[DisplayController.SECONDS];    }  


  public boolean timeIsNormal() {    

    byte[] digits = microwave.digits();      

  return (digits[DisplayController.TENS_OF_MINUTES] <= 5 &&         

       digits[DisplayController.MINUTES] <= 9 &&               

 digits[DisplayController.TENS_OF_SECONDS] <= 5 &&             

   digits[DisplayController.SECONDS] <= 9);   

 }   


 public boolean timeIsOk() {  

      byte[] digits = microwave.digits();   

     for (byte digit: digits) {        

    if (digit < 0 || digit > 9) {            


    return false;            }   

     }        return true;    } 

   public void secondsElapseCheckNormal(int time)  {      

  // System.out.println("" + time + " seconds elapse.");     

   boolean prevInNormalTime = timeIsNormal();     

   boolean currInNormalTime = false;     

   for (int i = 0; i < time*microwave.getTickRateInHz(); i++) {      

      microwave.tick();            assertTrue(timeIsOk()); 

           currInNormalTime = timeIsNormal();    

        if (prevInNormalTime) { assertTrue(currInNormalTime); }    

        prevInNormalTime = currInNormalTime;    

    }    }   

    @Property(trials = 100)   

 public void checkCookingTimes(@InRange(min="0",max="9") int digit1,                                  @InRange(min="0",max="9") int digit2,                                  @InRange(min="0", max="9") int digit3,                                  @InRange(min="0", max="9") int digit4,                                  @InRange(min = "0", max = "500") int time) throws Throwable {        microwave.setDoorOpen(false);        microwave.tick();        microwave.digitPressed(digit1);        microwave.tick();        microwave.digitPressed(digit2);        microwave.tick();        microwave.digitPressed(digit3);        microwave.tick();        microwave.digitPressed(digit4);        microwave.tick();        microwave.startPressed();        microwave.tick();        this.secondsElapse(time);        int totalTime = digit1 * 600 + digit2 * 60 + digit3 * 10 + digit4;        byte [] digits = microwave.digits();        int timeRemaining = calcTime(digits);        ModeController.Mode mode = microwave.getMode();        assertEquals(timeRemaining, Integer.max(totalTime-time, 0));

        assertTrue((time < totalTime) ?  

mode == ModeController.Mode.Cooking :             

   mode == ModeController.Mode.Setup);    }  

     @Property(trials = 100)  

  public void checkPreset(@InRange(min="0",max="6") int preset) throws Throwable {    

    try {            microwave.presetPressed(preset);            

microwave.tick();            int arrayIndex = preset - 1;         

   byte [] digits =microwave.digits();           

 Preset p = microwave.getPresets().get(arrayIndex);         

   assertTrue(calcTime(digits) == p.getTimeToCook());     

       assertTrue(microwave.getPowerLevel() == p.getPowerLevel());        } 

catch (IllegalArgumentException e) {       

     assertTrue(preset < 1 || preset > microwave.presets.size());        }    }   

 @Property(trials=100)    public void checkUnusualTimes(@InRange(min="0",max="9") int digit1,                                  @InRange(min="0",max="9") int digit2,                                  @InRange(min="0", max="9") int digit3,                                  @InRange(min="0", max="9") int digit4,                                  @InRange(min = "0", max = "500") int time) {        microwave.setDoorOpen(false);        microwave.tick();       

 microwave.digitPressed(digit1);        

microwave.tick();       

 microwave.digitPressed(digit2);       

 microwave.tick();      

  microwave.digitPressed(digit3);     

   microwave.tick();      

  microwave.digitPressed(digit4);      

  microwave.tick();       

 microwave.startPressed();       

 microwave.tick();       

 this.secondsElapseCheckNormal(time);       

int totalTime = digit1 * 600 + digit2 * 60 + digit3 * 10 + digit4;     

   byte [] digits = microwave.digits();       

 int timeRemaining = digits[0]*600 + digits[1]*60 + digits[2]*10 + digits[3];    

    ModeController.Mode mode = microwave.getMode();     

   assertEquals(timeRemaining, Integer.max(totalTime-time, 0));       

 assertTrue((time < totalTime) ?  mode == ModeController.Mode.Cooking :         

       mode == ModeController.Mode.Setup);  }}  