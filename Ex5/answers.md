# Exercise 5

## Exercise 1
The problem is that if M intercepts the message sent from A->B, M can use K_ab to encrypt the message that responds to A. Since the message A-> is not encrypted, but rather signed (meaning it does not achieve confidentiality) and can be read by M.

## Exercise 2
The message A->B can be intercepted by M, who can change K_ab. This means that B will receive a modified K_ab', whom B thinks is shared between A and B. A will thus not be able to authenticate messages from B, and B will not be able to authenticate messages from A. B will authenticate messages from M using K_ab', and think that they are coming from A.
This protocol does not ensure mutual authentication.

## Exercise 3
The message A->B is unencrypted and unsigned, so anyone could intercept it. If K_ab in the message from S->A is intercepted by, M could change it to any K_ab', which would allow M to read all messages between A and S.

It could be fixed by S adding their verification key to the message, before it's encrypted by PK_a. This would allow A to verify that the message is coming from S, and has not been tampered with.

## Exercise 4
a)
Owners name: John Doe, works for VeriSign. His public key is:
00:98:f2:89:c4:48:e1:3b:2c:c5:d1:48:67:80:53:
d8:eb:4d:4f:ac:31:a9:fd:11:68:94:ba:44:d8:48:
46:0d:fc:5c:6d:89:47:3f:9f:d0:c0:6d:3e:9a:8e:
ec:82:21:48:9b:b9:78:cf:aa:09:61:92:f6:d1:cf:
45:ca:ea:8f:df

Validity date:
Validity
Not Before: Jan 13 00:00:00 2000 GMT
Not After : Mar 13 23:59:59 2000 GMT

The name of the CA that signed it:
Issuer: O=VeriSign, Inc.,
OU=VeriSign Trust Network,
CN=VeriSign Class 1 CA Individual Persona Not Validated

Type and value of signature:
Signature Algorithm: md5WithRSAEncryption
5a:71:77:c2:ce:82:26:02:45:41:a5:11:68:d6:99:f0:4c:ce:
7a:ce:80:44:f4:a3:1a:72:43:e9:dc:e1:1a:9b:ec:64:f7:ff:
21:f2:29:89:d6:61:e5:39:bd:04:e7:e5:3d:7b:14:46:d6:eb:
8e:37:b0:cb:ed:38:35:81:1f:40:57:57:58:a5:c0:64:ef:55:
59:c0:79:75:7a:54:47:6a:37:b2:6c:23:6b:57:4d:62:2f:94:
d3:aa:69:9d:3d:64:43:61:a7:a3:e0:b8:09:ac:94:9b:23:38:
e8:1b:0f:e5:1b:6e:e2:fa:32:86:f0:c4:0b:ed:89:d9:16:e4:
a7:77

b)
The following states that it is not issued for a CA, but for a end user.
X509v3 Basic Constraints:
CA:FALSE

c)
Looking at the validity dates, it is not valid anymore. 

d)
MD5 is the algorithm used, which is broken
The persona is not validated in the issuer and the subject
The RSA publickey is only 512 bits, which is not that long (standards today say 1028).

## Exercise 5
https://store.steampowered.com/

a)
Owner name: store.steampowered.com at organisation Valve Corp. 
Algorithm: Elliptic Curve Public Key
Value: 00 04 86 E7 D8 94 AD 5B 4C A4 C5 E8 BE 75 6F A8
F2 18 67 00 4F C9 C4 67 71 CF 35 A7 CE 45 BF 25
2F C7 38 93 F2 B0 D2 89 46 07 05 E3 14 C2 36 0E
D6 C2 BD FA 81 86 BB 1C D0 D2 C3 AF 03 5D 1A 91
25 F5
Validaty dates: 22/12/2021, 01:00:00 CET - 22/12/2022, 00:59:59 CET
CA that signed: DigiCert SHA2 Extended Validation Server CA
Signature algorithm: PKCS #1 SHA-256 With RSA Encryption
Signature value: 77 9F D5 F4 7B FA 3E 6B 5B 70 14 2C 64 7E C1 8B
23 E1 11 49 15 85 8D EF D4 22 2C 0F 5C C1 FC 59
ED EA 09 42 EC E5 0F D2 F3 13 E4 5A F8 A9 20 44
E2 1C C3 E9 DD 57 ED 36 2D AA 28 2A 90 49 CF 1F
E4 DB DE 24 6B 1E 13 97 23 4D 02 C7 6D DA 8F 13
11 0E AD 0A BA 14 CE 10 68 8B 7C 92 DA 26 29 1E
41 FF AC 44 C0 71 87 09 16 F7 07 47 EF 9E 11 C5
1A 0B D2 F5 1E 15 5F 3E 26 EA 12 E9 7F 88 DF 48
B0 A9 FA 42 11 3E BC 29 18 DF A8 C7 D6 75 E4 C7
E7 E1 89 E3 48 82 47 F6 3D 7E A0 9D CD 1C 9E D6
0B D7 25 E8 64 4F 94 C8 92 B5 38 F4 2D 88 B6 25
2E F1 20 28 35 7D 40 F6 30 5D 40 D4 BE DE 49 7B
D4 CF 92 E3 82 58 AD 40 D2 E5 A4 6F 1E 13 2C C3
13 D5 85 8F 0F 72 FE FC E4 81 C8 8E E3 45 D1 01
80 67 7C 8E B1 66 15 EE 05 3E A1 C8 27 E5 7D 14
8A 23 CB 45 41 BC A6 BD CA B3 8B 4A 83 DC 41 67

b) 
CA:FALSE

c)
It is valid due to the certificate dates

d)
The browser says it's valid, SHA256 which is not broken.

## Exercise 6
Microsoft ECC Root Certificate Authority 2017

a)
Owner name: Microsoft ECC Root Certificate Authority 2017 at organisation Microsoft Corporation.
Algorithm: Elliptic Curve Public Key
Value: 04:D4:BC:3D:02:42:75:41:13:23:CD:80:04:86:02:51:2F:6A:A8:81:62:0B:65:CC:F6:CA:9D:1E:6F:4A:66:51:A2:03:D9:9D:91:FA:B6:16:B1:8C:6E:DE:7C:CD:DB:79:A6:2F:CE:BB:CE:71:2F:E5:A5:AB:28:EC:63:04:66:99:F8:FA:F2:93:10:05:E1:81:28:42:E3:C6:68:F4:E6:1B:84:60:4A:89:AF:ED:79:0F:3B:CE:F1:F6:44:F5:01:78:C0
Validaty dates: Thursday, 19 December 2019 at 00.06.45 CET - Saturday, 19 July 2042 at 01.16.04 CET
CA that signed: Microsoft Corporation (self signed)
Signature algorithm: ECDSA Signature with SHA-384
Signature value: -----BEGIN CERTIFICATE-----
MIICWTCCAd+gAwIBAgIQZvI9r4fei7FK6gxXMQHC7DAKBggqhkjOPQQDAzBlMQsw
CQYDVQQGEwJVUzEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMTYwNAYD
VQQDEy1NaWNyb3NvZnQgRUNDIFJvb3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5IDIw
MTcwHhcNMTkxMjE4MjMwNjQ1WhcNNDIwNzE4MjMxNjA0WjBlMQswCQYDVQQGEwJV
UzEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMTYwNAYDVQQDEy1NaWNy
b3NvZnQgRUNDIFJvb3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5IDIwMTcwdjAQBgcq
hkjOPQIBBgUrgQQAIgNiAATUvD0CQnVBEyPNgASGAlEvaqiBYgtlzPbKnR5vSmZR
ogPZnZH6thaxjG7efM3beaYvzrvOcS/lpaso7GMEZpn4+vKTEAXhgShC48Zo9OYb
hGBKia/teQ87zvH2RPUBeMCjVDBSMA4GA1UdDwEB/wQEAwIBhjAPBgNVHRMBAf8E
BTADAQH/MB0GA1UdDgQWBBTIy5lycFIM+Oa+sgRXKSrPQhDtNTAQBgkrBgEEAYI3
FQEEAwIBADAKBggqhkjOPQQDAwNoADBlAjBY8k3qDPlfXu5gKcs68tvWMoQZP3zV
L8KxzJOuULsJMsbG7X7JNpQS5GiFBqIb0C8CMQCZ6Ra0DvpWSNSkMBaReNtUjGUB
iudQZsIxtzm6uBoiB078a1QWIP8rtedMDE2mT3M=
-----END CERTIFICATE-----

b)
CA:TRUE

c)
It is valid due to the certificate dates

d)
ECDSA Signature with SHA-384 which is not broken.