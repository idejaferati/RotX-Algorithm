# DataSecurity

## ROT(X) Algorithm

This project implements this algorithm through C# language program.

A rotational cipher, Rot(X), is an ancient enocoding that, given a message, returns a message where each letter has been replaced by the letter exactly X letters after it in the alphabet ordering. Letters near the end of the alphabet wrap around.

One of the most common ROT(X) algorithm is the algorithm in which X = 13. 
ROT13 is a special case of the Code of Caesar.
The translation table for ROT(13) looks like:

```
ABCDEFGHIJKLMNOPQRSTUVWXYZ
NOPQRSTUVWXYZABCDEFGHIJKLM
```
and therefore, for example, the message JETA/IDEJA/JETA becomes WRGN/VQRWN/WRGN 
