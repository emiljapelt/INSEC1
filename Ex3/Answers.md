# Exercises

## Review questions

### 2.1

Cryptanalysis use knowledge about the algorithms and perhaps about the general characteristics about the plaintext to deduce a specific plaintext or to deduce the key being used. Bruteforce attacks try all possible ways to decrypt a ciphertext.

## 2.2

Symmetric encryption algorithms can be attacked using cryptanalysis and bruteforce previously described.

## 2.5

A hash function is a function that given an input of any size produces a digest of fixed size. A one-way hash function, H, has the property that for any output h it is computationally infeasible to find x such that H(x)=h.

## 2.7

The hash function can be applied to a block of data of any size.  
The hash function produces a fixed-length output.  
The value of the hash function is relatively easy to compute for any input, making both hardware and software implementations practical.  
One-way (or preimage) hash function: A hash function where for any given code h, it is computationally infeasible to find x such that H(x)=h.  
Second preimage resistant (or weak collision resistant) hash function: For any given block x, it is computationally infeasible to find y≠x with H(y)=H(x). Guarantees that it is impossible to find an alternative message with the same hash value as a given message.  
Collision resistant (or strong collision resistant) hash function: It is computationally infeasible to find any pair (x,y) such that H(x)=H(y).  

## Problems

### Problem 2.1

Electronic Codebook (ECB) is a mode in which the plaintext is handled b bits at a time. Each block is encrypted using the same key.  
ECB cannot be used for very large plaintexts or very regular plaintext. This is because of security issues.  
It is not a secure method of encryption because if the same block of plaintext appear more than once they will have the same ciphertext. An adversary can use this to their advantage to decrypt the message.

### Problem 2.6

Because each bit is either 0 or 1 the minimum number of plaintexts needed to get every possible hash value is 2^16=65.536. Therefore, the number of plaintexts needed to get the same hash value is 2^16+1=65.537.
