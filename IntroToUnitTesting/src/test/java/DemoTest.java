import static org.junit.Assert.*;

import org.junit.Test;

public class DemoTest {

    @Test
    public void testValidTriangle1() {
        assertTrue(Demo.isTriangle(3, 4, 5)); // Right-angled triangle
    }

    @Test
    public void testValidTriangle2() {
        assertTrue(Demo.isTriangle(5, 12, 13)); // Right-angled triangle
    }

    @Test
    public void testValidTriangle3() {
        assertTrue(Demo.isTriangle(5, 5, 8)); // Scalene triangle
    }

    @Test
    public void testValidTriangle4() {
        assertTrue(Demo.isTriangle(8, 8, 8)); // Equilateral triangle
    }

    @Test
    public void testValidTriangle6() {
        assertTrue(Demo.isTriangle(4, 4, 3)); // Isosceles triangle
    }

    @Test
    public void testInvalidTriangle1() {
        assertFalse(Demo.isTriangle(1, 1, 3)); // Sum of any two sides must be greater than the third side
    }

    @Test
    public void testInvalidTriangle3() {
        assertFalse(Demo.isTriangle(0, 4, 5)); // Zero side length
        assertFalse(Demo.isTriangle(3, 0, 5)); // Zero side length
        assertFalse(Demo.isTriangle(3, 4, 0)); // Zero side length
    }

    @Test
    public void testNegativeValues4() {
        assertFalse(Demo.isTriangle(-3, 4, 5)); // Negative side length
        assertFalse(Demo.isTriangle(3, -4, 5)); // Negative side length
        assertFalse(Demo.isTriangle(3, 4, -5)); // Negative side length
    }

    @Test
    public void testTwoSidesNegative5() {
        assertFalse(Demo.isTriangle(-3, -4, 5)); // Negative side lengths
        assertFalse(Demo.isTriangle(-3, 4, -5)); // Negative side lengths
        assertFalse(Demo.isTriangle(3, -4, -5)); // Negative side lengths
    }

    @Test
    public void testTwoSidesZero6() {
        assertFalse(Demo.isTriangle(0, 0, 5)); // Two sides are zero
        assertFalse(Demo.isTriangle(0, 5, 0)); // Two sides are zero
        assertFalse(Demo.isTriangle(5, 0, 0)); // Two sides are zero
    }

    @Test
    public void testAllSidesNegative7() {
        assertFalse(Demo.isTriangle(-3, -4, -5)); // All sides are negative
    }

    @Test
    public void testAllSidesEqualZero8() {
        assertFalse(Demo.isTriangle(0, 0, 0)); // All sides are zero
    }

    @Test
    public void testDouble() {
        assertTrue(Demo.isTriangle(3.5, 4.5, 5.5)); // Double side lengths
    }
}
