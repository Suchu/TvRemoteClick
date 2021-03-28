
    TV remote control has arrow buttons and an OK button.

    Can use these to move a "cursor" on a logical screen keyboard to type "words"...

    The screen "keyboard" layout looks like this

    a	b	c	d	e	1	2	3
    f	g	h	i	j	4	5	6
    k	l	m	n	o	7	8	9
    p	q	r	s	t	.	@	0
    u	v	w	x	y	z	_	/

    task:
    How many button presses are required to type a given word?

    Notes
    The cursor always starts on the letter a (top left)
    Remember to also press OK to "accept" each character.
    Take a direct route from one character to the next
    The cursor does not wrap (e.g. you cannot leave one edge and reappear on the opposite edge)
    A "word" (for the purpose of this Kata) is any sequence of characters available on my virtual "keyboard"

    Example
    word = code

    c => a-b-c-OK = 3
    o => c-d-e-j-o-OK = 5
    d => o-j-e-d-OK = 4
    e => d-e-OK = 2

    Answer: 3+5+4+2 = 14
    
    Explanation:
    - TvKeyboard is for store a the keys in the keyboard as a string.
    - initialized position of word which is 0 right now because the cusrsor always statrts on the letter a(top left).
    - initialized result as a 0 and ok as 1 because we have to click OK to fix the character we want.
    - lets search the given word, "code" from the stored string TvKeyboard with the help of indexOf and 
      assign the index of that character in the remoteCharIndex.
    - Now we can get our first number of clicks by indexing position and remoteCharIndex
      Math.Abs(position % 8 - remoteCharIndex % 8) + Math.Abs(position / 8 - remoteCharIndex / 8) + ok //here ok = 1 and 
      max character index is 8 of keyboard 
    - In this way we get our first number of clicks from the position 0 and character index 2(remoteCharIndex) which is "c".
    - Now the postion of the cursor is current character index which is 2.
    - In this way if we make foreach loop for each character of given word and sum, we can find the total number of clicks.
    
    Output calculation: 
    note: 
    word = code
    for c => a-b-c-OK
    position = 0 remoteCharIndex = 2
    result = Math.Abs(0 % 8 - 2 % 8) + Math.Abs(0 / 8 - 2 / 8) + 1
           = Math.Abs(0 - 2) + Math.Abs(0 - 0.25) + 1
           = 3
           
    for o => c-d-e-j-o-OK
    position = 2 remoteCharIndex = 20
    result = Math.Abs(2 % 8 - 20 % 8) + Math.Abs(2 / 8 - 20 / 8) + 1
           = Math.Abs(2 - 4) + Math.Abs(0.25 - 2.5) + 1
           = 5
           
    for d => o-j-e-d-OK
    position = 20 remoteCharIndex = 3
    result = Math.Abs(20 % 8 - 3 % 8) + Math.Abs(20 / 8 - 3 / 8) + 1
           = Math.Abs(4 - 3) + Math.Abs(2.5 - 0.375) + 1
           = 4
           
    for e => d-e-OK 
    position = 3 remoteCharIndex = 4
    result = Math.Abs(3 % 8 - 4 % 8) + Math.Abs(3 / 8 - 4 / 8) + 1
           = Math.Abs(3 - 4) + Math.Abs(0.375 - 0.5) + 1
           = 2
           
    result = 3 + 5 + 4 + 2 = 14
    
    
   
    
 
 
