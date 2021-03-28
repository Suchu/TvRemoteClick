/*
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
 
 */

using System;

namespace TvRemoteClick
{
    class RemoteControl
    {
        
        public static int TvRemote(string word = "code")
        {
            const string TvKeyboard = "abcde123fghij456klmno789pqrst.@0uvwxyz_/";

            int result = 0;
            int position = 0;
            int ok = 1;

            foreach (char ch in word )
            {
               int remoteCharIndex = TvKeyboard.IndexOf(ch);

                result += Math.Abs(position % 8 - remoteCharIndex % 8) +
                          Math.Abs(position / 8 - remoteCharIndex / 8) + ok;

                position = remoteCharIndex;
            }

            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Sum of total clicks of word = \"code\" is " + TvRemote());
        }
    }
}
