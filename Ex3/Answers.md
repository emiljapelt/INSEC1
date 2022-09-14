The hash function can be applied to a block of data of any size.  
The hash function produces a fixed-length output.  
The value of the hash function is relatively easy to compute for any input, making both hardware and software implementations practical.  
One-way (or preimage) hash function: A hash function where for any given code h, it is computationally infeasible to find x such that H(x)=h.  
Second preimage resistant (or weak collision resistant) hash function: For any given block x, it is computationally infeasible to find y≠x with H(y)=H(x). Guarantees that it is impossible to find an alternative message with the same hash value as a given message.  
Collision resistant (or strong collision resistant) hash function: It is computationally infeasible to find any pair (x,y) such that H(x)=H(y).  
