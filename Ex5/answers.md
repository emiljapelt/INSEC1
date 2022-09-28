# Exercise 5

## Exercise 1
The problem is that if M intercepts the message sent from A->B, M can use K_ab to encrypt the message that responds to A. Since the message A-> is not encrypted, but rather signed (meaning it does not achieve confidentiality) and can be read by M.

## Exercise 2
The message A->B can be intercepted by M, who can change K_ab. This means that B will receive a modified K_ab', whom B thinks is shared between A and B. A will thus not be able to authenticate messages from B, and B will not be able to authenticate messages from A. B will authenticate messages from M using K_ab', and think that they are coming from A.
This protocol does not ensure mutual authentication.