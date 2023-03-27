string text = "ALA MA KOTA";
text = text.Replace('G', '@');
text = text.Replace('A', 'G');
text = text.Replace('@', 'A');

text = text.Replace('D', '@');
text = text.Replace('E', 'D');
text = text.Replace('@', 'E');

text = text.Replace('R', '@');
text = text.Replace('Y', 'R');
text = text.Replace('@', 'Y');

text = text.Replace('P', '@');
text = text.Replace('O', 'P');
text = text.Replace('@', 'O');

text = text.Replace('L', '@');
text = text.Replace('U', 'L');
text = text.Replace('@', 'U');

text = text.Replace('K', '@');
text = text.Replace('I', 'K');
text = text.Replace('@', 'I');


Console.WriteLine(text);
