# daily-coding-problem

https://www.dailycodingproblem.com/  sends an email with a problem every day.
This repo is created to provide solutions of those problems in C#

IMPORTANT: The solution may or may not have issues as these are tested against a smaller set of test cases. Anyone who wants to contribute to testing these solutions please contact.

## Below are the problems whose code is available:

### Problem 485: Given an integer k and a string s, find the length of the longest substring that contains at most k distinct characters.
Example: given s = "abcba" and k = 2, the longest substring with k distinct characters is "bcb"
___________________________________________________________________________________________________________________________________________________________________________________
### Problem 487: Given a binary tree and a particular node, find all cousins of that node.
Two nodes in a binary tree can be called cousins if they are on the same level of the tree but have different parents. For example, in the following diagram 4 and 6 are cousins.
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;/ &nbsp;&nbsp;&nbsp;\ &nbsp;&nbsp;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3&nbsp;<br>
&nbsp;&nbsp;&nbsp;/ &nbsp;&nbsp;\ &nbsp;&nbsp;&nbsp;/ &nbsp;&nbsp;&nbsp;&nbsp;<br>
&nbsp;&nbsp;4&nbsp;&nbsp;&nbsp;&nbsp;5&nbsp;6&nbsp;&nbsp;&nbsp;&nbsp;<br>
___________________________________________________________________________________________________________________________________________________________________________________

### Problem 489: Given an array of elements, return the length of the longest subarray where all its elements are distinct.
For example, given the array [5, 1, 3, 5, 2, 3, 4, 1], return 5 as the longest subarray of distinct elements is [5, 2, 3, 4, 1].

___________________________________________________________________________________________________________________________________________________________________________________
### Problem 490: Given the root to a binary tree, return its bottom view.
The horizontal distance of a binary tree node describes how far left or right the node will be when the tree is printed out.

More rigorously, we can define it as follows:

The horizontal distance of the root is 0.
The horizontal distance of a left child is hd(parent) - 1.
The horizontal distance of a right child is hd(parent) + 1.

For example, for the following tree, hd(1) = -2, and hd(6) = 0
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;5<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;/&nbsp;&nbsp;&nbsp;\ &nbsp;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;7&nbsp;<br>
&nbsp;&nbsp;&nbsp;/&nbsp;&nbsp;\ &nbsp;&nbsp;/&nbsp;&nbsp;\ &nbsp;<br>
&nbsp;&nbsp;1&nbsp;&nbsp;&nbsp;&nbsp;4&nbsp;6&nbsp;&nbsp;&nbsp;9&nbsp;<br>
&nbsp;/&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;/&nbsp;<br>
0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;8&nbsp;<br>

___________________________________________________________________________________________________________________________________________________________________________________
### Problem 491: Write a program that checks whether an integer is a palindrome (without using string)
For example, 121 is a palindrome, as well as 888. 678 is not a palindrome. Do not convert the integer into a string.
