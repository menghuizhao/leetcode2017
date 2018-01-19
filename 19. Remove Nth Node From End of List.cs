/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) return head;
        Stack<ListNode> st = new Stack<ListNode>();
        ListNode node = head;
        while(node != null) {
            st.Push(node);
            node = node.next;
        }
        ListNode nth = null;
        for(int i = 0; i < n; i++){
            nth = st.Pop();
        }
        // not empty
        if(st.Count > 0){
            ListNode n_1th = st.Pop();
            n_1th.next = nth.next;
            return head;
        }
        // stack is empty, nth from last node is the head node
        return head.next;
    }
}
