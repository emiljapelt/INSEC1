# Block 1
## Problem 1:
Confidentiality: Cannot access account and student information without both student card and student number. Either the student number is secret, or the card does not contain information about which student it belongs to.
Integrity: Individuals can only change information on their account if they have both the card and student number.
Availability: If both the card and student number are present and match, the student is granted access to the account.

## Problem 1.4
### A: 
Confidentiality: Low, because information is public
Integrity: High if the information is important (for example government info)
Availability: Low-Medium, depends on the type of service.
### B:
Confidentiality: High, information about investigations may not be accessed by criminals
Integrity: High, proofs may not be deleted or altered
Availability: Low, since information could always be entered in later, or a court day could be moved
### C:
Confidentiality: Low, because privacy is not important.
Integrity: Medium, might perform wrong work tasks
Availability: Medium, administration is difficult when no one knows what to do.
### D:
Confidentiality: High for the sensitive part, low for the administrative part
Integrity: High for the sensitive part, medium for the administrative part
Availability: Low for the sensitive part, low for the administrative part.
### E:
Confidentiality: High for sensor data, medium for routine administration.
Integrity: High for sensor data (if tampered with, might cause explosions?)
Availability: High for sensor data, low for administrative part.


## Probelm 1.5
A: not a fail-safe default. The default is to grant access, so the if-statement should be inverted, so that access is only granted on ACCESS_GRANTED

DWORD dwRet = IsAccessAllowed(...);
if (dwRet == ACCESS_GRANTED) {
// Security check OK.
} else {
// Security check failed.
}
The IT department is considering to introduce multi-step authentication to protect their users. Before applying the new policy, the department asks for your advice. Multi-step authentication requires the user to choose any two of the following authentication methods at each login.

Economy of mechanism: There are 7*6=42 many combinations, which is complex for the IT-department to maintain. Quite overkill.

Layering: Email, sms, and call all just require access to the phone. Therefor there are not multiple layers of protection

Separation of privilege: Good to have multifactor authentication.

# BLOCK 2.
## 1.1:
Is a group as demonstrated in class
## 1.2:
Closure: for any two bit-strings, applying XOR will yield another bit-string
Identity: 0. For any value x, it applies that xXOR0 equals 0
Inverse: For any value x the inverse is x (0 xor 0 = 0, and 1 xor 1 = 0)
Associativity: (1 xor 0) xor 1 = 0, (1 xor 1) xor 0 = 0
Communaitivity: x XOR y == y XOR x
## 1.3:
Closure: Any integer mod 20 is in the range 0 to 19 (inclusive)
Inverse: There is always an inverse for x, x minus 20.
Identity: x + 0 = x, 0 is the identity element.
Inverse operation is 20 - x.
## 2.1:
We dont have an inverse, we cannot get the identity which is 1.
## 2.2:
No inverse, we cannot get the identity which is the empty list.






