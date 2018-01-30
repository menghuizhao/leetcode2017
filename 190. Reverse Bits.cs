public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        for (int i = 0; i < 32; i++) {
            result += n & 1;
            n >>= 1;   // 必须进行无符号位移
            if (i < 31) // 最后一次不需要进行位移，因为没有下一个循环了不用挪出空位
               result <<= 1;
        }
        return result;
    }
}
