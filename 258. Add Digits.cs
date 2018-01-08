//Digital root https://en.wikipedia.org/wiki/Digital_root
public class Solution {
    public int AddDigits(int num) {
        return num - 9 * ((num - 1) / 9);
    }
}
