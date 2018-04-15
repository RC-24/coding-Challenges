# Alphabet Cipher

"The Alphabet Cipher", published by Lewis Carroll in 1868, describes a Vigenère cipher for passing secret messages. 
The cipher involves alphabet substitution using a shared keyword. Using the alphabet cipher to transmit messages follows this procedure:

You must use a substitution chart, where each row of the alphabet is rotated by one as each letter goes down the chart. All test cases will utilize this same substitution chart.


<br>&nbsp;&nbsp;<b>ABCDEFGHIJKLMNOPQRSTUVWXYZ</b>
<br><b>A</b> abcdefghijklmnopqrstuvwxyz
<br><b>B</b> bcdefghijklmnopqrstuvwxyza
<br><b>C</b> cdefghijklmnopqrstuvwxyzab
<br><b>D</b> defghijklmnopqrstuvwxyzabc
<br><b>E</b> efghijklmnopqrstuvwxyzabcd
<br><b>F</b> fghijklmnopqrstuvwxyzabcde
<br><b>G</b> ghijklmnopqrstuvwxyzabcdef
<br><b>H</b> hijklmnopqrstuvwxyzabcdefg
<br><b>I</b> ijklmnopqrstuvwxyzabcdefgh
<br><b>J</b> jklmnopqrstuvwxyzabcdefghi
<br><b>K</b> klmnopqrstuvwxyzabcdefghij
<br><b>L</b> lmnopqrstuvwxyzabcdefghijk
<br><b>M</b> mnopqrstuvwxyzabcdefghijkl
<br><b>N</b> nopqrstuvwxyzabcdefghijklm
<br><b>O</b> opqrstuvwxyzabcdefghijklmn
<br><b>P</b> pqrstuvwxyzabcdefghijklmno
<br><b>Q</b> qrstuvwxyzabcdefghijklmnop
<br><b>R</b> rstuvwxyzabcdefghijklmnopq
<br><b>S</b> stuvwxyzabcdefghijklmnopqr
<br><b>T</b> tuvwxyzabcdefghijklmnopqrs
<br><b>U</b> uvwxyzabcdefghijklmnopqrst
<br><b>V</b> vwxyzabcdefghijklmnopqrstu
<br><b>W</b> wxyzabcdefghijklmnopqrstuv
<br><b>X</b> xyzabcdefghijklmnopqrstuvw
<br><b>Y</b> yzabcdefghijklmnopqrstuvwx
<br><b>Z</b> zabcdefghijklmnopqrstuvwxy

Both people (sender and receiver) exchanging messages must agree on the secret keyword. To be effective, this keyword should not be written down anywhere, but memorized.

To encode the message, first enter the message. Then, enter the keyword:
<br>thepackagehasbeendelivered 	<-- Message
<br>snitch						<-- Keyword

Next, the keyword should be padded out to match the length of the message
<br>thepackagehasbeendelivered 	<-- Message
<br>snitchsnitchsnitchsnitchsn	<-- Keyword

Now you can look up the column S in the table and follow it down until it meets the T row. The value at the intersection is the letter L. Thus, in this case, the letter t is encoded as l.

The encoded message is now lumicjcnoxjhkomxpkwyqogywq

To decode, the other person would use the secret keyword and the table to look up the letters in reverse.
