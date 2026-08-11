# comp2021-2026-2-portfolio-a1987873-2-


## Workshop 1

### Environment Check

#### dotnet --info
![info](<Week1a.Task1.Screenshot1.png>)
![dotnet info](<Week1a.Task1.Screenshot2.png>)


#### Debugger

![Debugger](<Week1a.Task1.Screenshot3.png>)

---

### Payroll Calculator

![Payroll Output](<Screenshot 2026-08-07 131022.png>)


---

### Git Log

![Git Log](<Screenshot 2026-08-07 130415.png>)

## Workshop 2

Changing from procedural to class-based design, made the program more organised, as payroll attributes and data are kept inside the Payroll class. In the procedural version, almost everything was in the Program.cs file. Whereas, the payroll logic seperates the payroll logic from user interaction, which made it easier to reuse, test and maintain.

Because of Static typing, I had to define the types, parameter and variable before running the program. It helps catching the mistakes earlier during compilation. For example, C# distinguishes between double and decimal, so I had to be more careful about which type I use, but the compiler gives useful errors when the types do not match. 