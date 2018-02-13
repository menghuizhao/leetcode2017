/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null) return head;
        ListNode fakeHead = new ListNode(0);
        fakeHead.next = head;
        ListNode p = fakeHead;
        while(p != null){
            ListNode n = p.next;
            while(n != null && n.val == val){
                n = n.next;
            }
            p.next = n;
            p = p.next;
        }
        return fakeHead.next;
    }
}
