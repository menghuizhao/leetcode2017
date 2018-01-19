/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
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
