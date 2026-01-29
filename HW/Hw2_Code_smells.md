#Code Smell: Speculative Generality #
Definition: There’s an unused class, method, field or parameter. 
How does it occur?: เขียนโค้ดเผื่อแล้วลืมเรียกใช้
How to fix:
- Unused abstract classes: Collapse hierachy
- Unnecessary relation to another class:Change to Inline Class
- Unused Methods:Change to Inline Methods
- Unused Parameter:Remove Parameter(s)
- Unused Fields: JUST DELETE
When to Ignore:
1. No effect on efiiciency = no need to fix
2. If code too problematic to fix, fixing takes a long time/ needs new implementation method(s) = DON'T
3. 3.Make sure that these class are NOT needed by other classes/ fields/ methods or else implementing is a hassle.
