# Problems

## Problem 4.5

644 (octal) in binary is:
110100100
This is equavalent to:
rw-r--r--
The owner can read and write.
The group can read.
All others can read.

730 (octal) in binary is:
111011011
This is equavalent to:
rwx-wx---
The owner can read and write.
The group can read.
All others can read.

Because the group has write access they can create, rename, and delete.
Because the group has execute access they can descend the directory and search for files.

## Problems 4.8

R1:can_be_provided(u, m, e) <-
    (Age(u) > 35 && Finding(m) is RG) ||
    (Age(u) <= 35 && Finding(m) is in {RG, TG})
