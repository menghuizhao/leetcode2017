/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null) return head;
        ListNode fake = new ListNode(0);
        fake.next = head;
        ListNode p = fake;
        while(p.next != null && p.next.next != null){ //validate that a pair exits
            var temp = p.next.next;
            p.next.next = temp.next;
            temp.next = p.next;
            p.next = temp;
            p = p.next.next;

        }
        return fake.next;
    }
}
