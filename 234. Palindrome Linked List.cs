/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(head == null) return true;
        ListNode middle = findMiddle(head);
        middle.next = reverse(middle.next);
        ListNode p1 = head;
        ListNode p2 = middle.next;
        while(p1 != null && p2 != null && p1.val == p2.val){
            p1 = p1.next;
            p2 = p2.next;
        }
        return p2 == null;
    }
    //快慢指针找中点
    private ListNode findMiddle(ListNode head) {
       if (head == null) {
           return null;
       }
       ListNode slow = head;
       ListNode fast = head;
       while (fast.next != null && fast.next.next != null) {
           slow = slow.next;
           fast = fast.next.next;
       }
       return slow;
   }
   //Reverse link list
   private ListNode reverse(ListNode head) {
        ListNode foreNode = null;
        ListNode iterator = head;
        while(iterator != null){
            ListNode postNode = iterator.next;
            iterator.next = foreNode;
            foreNode = iterator;
            iterator = postNode;
        }
        return foreNode;
    }
}
