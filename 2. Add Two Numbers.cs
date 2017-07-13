/**
 * Definition for singly-linked list.
 * public class ListNode {
 * 	public int val;
 * 	public ListNode next;
 * 	public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
   	 
    	if(l1 == null || l2 == null) return l1;
   	 
    	ListNode head = new ListNode(0);//return head.next later
    	ListNode current = head;
    	int flag = 0;
    	while(l1 != null || l2 != null || flag == 1){
        	int temp = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + flag;
        	current.next = new ListNode(temp % 10);
        	flag = temp / 10;
        	current = current.next;
        	l1 = l1 != null ? l1.next : l1;
        	l2 = l2 != null ? l2.next : l2;
    	}
    	return head.next;
	}
}
