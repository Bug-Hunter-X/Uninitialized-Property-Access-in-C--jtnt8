# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.  The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a corrected version.

## Problem

In C#, class properties don't automatically initialize to a default value (except for value types which will be zero, false, or null).  If you try to access a property before assigning it a value, you might get unexpected results, including exceptions.