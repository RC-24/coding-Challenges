# Alphabet Cipher

"The Alphabet Cipher", published by Lewis Carroll in 1868, describes a Vigenère cipher for passing secret messages. 
The cipher involves alphabet substitution using a shared keyword. Using the alphabet cipher to transmit messages follows this procedure:

You must make a substitution chart like this, where each row of the alphabet is rotated by one as each letter goes down the chart. All test cases will utilize this same substitution chart.

  ABCDEFGHIJKLMNOPQRSTUVWXYZ
A abcdefghijklmnopqrstuvwxyz
B bcdefghijklmnopqrstuvwxyza
C cdefghijklmnopqrstuvwxyzab
D defghijklmnopqrstuvwxyzabc
E efghijklmnopqrstuvwxyzabcd
F fghijklmnopqrstuvwxyzabcde
G ghijklmnopqrstuvwxyzabcdef
H hijklmnopqrstuvwxyzabcdefg
I ijklmnopqrstuvwxyzabcdefgh
J jklmnopqrstuvwxyzabcdefghi
K klmnopqrstuvwxyzabcdefghij
L lmnopqrstuvwxyzabcdefghijk
M mnopqrstuvwxyzabcdefghijkl
N nopqrstuvwxyzabcdefghijklm
O opqrstuvwxyzabcdefghijklmn
P pqrstuvwxyzabcdefghijklmno
Q qrstuvwxyzabcdefghijklmnop
R rstuvwxyzabcdefghijklmnopq
S stuvwxyzabcdefghijklmnopqr
T tuvwxyzabcdefghijklmnopqrs
U uvwxyzabcdefghijklmnopqrst
V vwxyzabcdefghijklmnopqrstu
W wxyzabcdefghijklmnopqrstuv
X xyzabcdefghijklmnopqrstuvw
Y yzabcdefghijklmnopqrstuvwx
Z zabcdefghijklmnopqrstuvwxy

Both people (sender and receiver) exchanging messages must agree on the secret keyword. To be effective, this keyword should not be written down anywhere, but memorized.

To encode the message, first enter the message. Then, enter the keyword:
thepackagehasbeendelivered 	<-- Message
snitch						<-- Keyword

Next, the keyword should be padded out to match the length of the message
thepackagehasbeendelivered 	<-- Message
snitchsnitchsnitchsnitchsn	<-- Keyword

Now you can look up the column S in the table and follow it down until it meets the T row. The value at the intersection is the letter L. Thus, in this case, the letter t is encoded as l.

The encoded message is now lumicjcnoxjhkomxpkwyqogywq

To decode, the other person would use the secret keyword and the table to look up the letters in reverse.