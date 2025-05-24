# Isolation Levels and Concurrency Anomalies

### I've read alot about Isolation Levels in my time as a SWE but aside from a regular dirty read I have yet to SEE all the concurrency anomalies that can come along with it first hand.

### In this project, we attempt to simulate concurrency issues using a normal Bank Application. 

### We will attempt to use every type of Isolation Level:
### - No Isolation
### - Read Uncommited
### - Read Commited
### - Repeatable Read
### - Snapshot Isolation
### - Serializable

### We will attempt to simulate the following anomalies:
### - Dirty Writes
### - Dirty Reads
### - Lost Updates
### - Non-Repeatable Reads/Fuzzy Reads
### - Read Skew
### - Phantom Reads
### - Write Skews
### - Dead Locks


### The goal isn't the bank application but more to actually visualize and understand which actions would cause these anomalies and how each level is introduced to solve them
