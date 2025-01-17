import org.junit.After;

import org.junit.Before;

import org.junit.Test;


import static org.junit.Assert.assertFalse;

import static org.junit.Assert.assertTrue;


public class DemoTest {


    @Before

    public void setUp() {

        // Initialization, if needed

    }


    @After

    public void tearDown() {

        // Cleanup, if needed

    }


    @Test

    public void testValidTriangle() {

        assertTrue(Demo.isTriangle(3, 4, 5)); // Valid triangle (Pythagorean triplet)

        assertTrue(Demo.isTriangle(5, 12, 13)); // Valid triangle (another Pythagorean triplet)

        assertTrue(Demo.isTriangle(7, 8, 9)); // Valid triangle

    }


    @Test

    public void testInvalidTriangle() {

        assertFalse(Demo.isTriangle(1, 1, 3)); // Invalid triangle (sum of two sides not greater than the third)

        assertFalse(Demo.isTriangle(3, 4, 7)); // Invalid triangle (sum of two sides not greater than the third)

        assertFalse(Demo.isTriangle(0, 0, 0)); // Invalid triangle (zero side lengths)

    }


    @Test

    public void testNegativeSideLengths() {

        assertFalse(Demo.isTriangle(-3, 4, 5)); // Negative side length

        assertFalse(Demo.isTriangle(3, -4, 5)); // Negative side length

        assertFalse(Demo.isTriangle(3, 4, -5)); // Negative side length

        assertFalse(Demo.isTriangle(-3, -4, -5)); // Negative side lengths

    }


    @Test

    public void testZeroSideLengths() {

        assertFalse(Demo.isTriangle(0, 4, 5)); // Zero side length

        assertFalse(Demo.isTriangle(3, 0, 5)); // Zero side length

        assertFalse(Demo.isTriangle(3, 4, 0)); // Zero side length

        assertFalse(Demo.isTriangle(0, 0, 0)); // Zero side lengths

    }


    @Test

    public void testDifferentOrder() {

        assertTrue(Demo.isTriangle(3, 4, 5)); // Same as first valid triangle test

        assertTrue(Demo.isTriangle(5, 3, 4)); // Permutation of side lengths

        assertTrue(Demo.isTriangle(4, 5, 3)); // Permutation of side lengths

    }


    @Test

    public void testIsoscelesTriangle() {

        assertTrue(Demo.isTriangle(5, 5, 7)); // Isosceles triangle

        assertTrue(Demo.isTriangle(5, 7, 5)); // Isosceles triangle

        assertTrue(Demo.isTriangle(7, 5, 5)); // Isosceles triangle

    }


    @Test

    public void testEquilateralTriangle() {

        assertTrue(Demo.isTriangle(5, 5, 5)); // Equilateral triangle

    }


    @Test

    public void triangleTest1() {

        assertTrue(Demo.isTriangle(3, 2, 4)); // Valid triangle

    }


    @Test

    public void triangleTest2() {

        assertTrue(Demo.isTriangle(4, 3, 5)); // Valid triangle

    }


    @Test

    public void triangleTest3() {

        assertTrue(Demo.isTriangle(5, 3, 5)); // Valid triangle

    }


    @Test

    public void triangleTest4() {

        assertTrue(Demo.isTriangle(6, 4, 5)); // Valid triangle

    }


    @Test

    public void triangleTest5() {

        assertTrue(Demo.isTriangle(7, 5, 6)); // Valid triangle

    }


    @Test

    public void triangleTest6() {

        assertFalse(Demo.isTriangle(13, 2, 4)); // Invalid triangle

    }


    @Test

    public void triangleTest7() {

        assertFalse(Demo.isTriangle(4, 3, 15)); // Invalid triangle

    }


    @Test

    public void triangleTest8() {

        assertFalse(Demo.isTriangle(3, 22, 4)); // Invalid triangle

    }


    @Test

    public void triangleTest9() {

        assertFalse(Demo.isTriangle(24, 2, 5)); // Invalid triangle

    }


    @Test

    public void triangleTest10() {

        assertFalse(Demo.isTriangle(34, 2, 4)); // Invalid triangle

    }


    @Test

    public void triangleTest11() {

        assertFalse(Demo.isTriangle(2, 10, 4)); // Invalid triangle

    }

}