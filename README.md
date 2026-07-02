# Class Management System (C# Console Application)

## Overview
This project is a console-based Class Management System built using C#. It demonstrates the use of core data structures such as:

- Singly Linked List (for student storage)
- Queue (for managing lab records)
- Stack (for managing assignments)

The system allows users to manage students, their lab scores, and assignments while maintaining structured and efficient data handling.

---

## Features

### Student Management
- Add student
- Remove student
- Display all students (sorted alphabetically using linked list)
- Search for student

### Lab Management (Queue - FIFO)
- Add lab
- Remove lab
- Update lab score
- Display all labs
- Prevent duplicate lab numbers per student

### Assignment Management (Stack - LIFO)
- Add assignment
- Remove assignment
- Update assignment
- Display assignments
- Prevent duplicate assignment numbers

---

## Data Structures Used

| Structure | Purpose |
|----------|--------|
| Linked List | Stores students in sorted order |
| Queue | Stores lab records in FIFO order |
| Stack | Stores assignments in LIFO order |

---

## Core Classes

- `Student`
- `Lab`
- `Assignment`
- `StudentLinkedList`
- `StudentNode`
- `Program`

---

## Validation Rules

- Student names must contain letters only
- Lab score must not exceed max score (10)
- Assignment score must not exceed max score
- Duplicate labs and assignments are not allowed per student
