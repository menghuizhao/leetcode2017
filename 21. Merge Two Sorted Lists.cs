/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        ListNode p1 = l1;
        ListNode p2 = l2;
        ListNode head = new ListNode(0); //fake head
        ListNode p = head;
        while(p1 != null && p2 != null){
            if(p1.val <= p2.val){
                p.next = new ListNode(p1.val);
                p1 = p1.next;
            }
            else{
                p.next = new ListNode(p2.val);
                p2 = p2.next;
            }
            p = p.next;
        }
        if(p1 == null){
            p.next = p2;
        }
        else{//p2 == null
            p.next = p1;
        }
        return head.next;
    }
}
