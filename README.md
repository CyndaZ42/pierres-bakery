# Pierre's Bakery

#### By _**Zac Waggoner**_  

##### ── BUY SOME BREAD. ──  

---

## Table of Contents

[Description](#description)  
[Technologies Used](#technologies-used)  
[Setup and Installation](#setupinstallation-requirements)  
[Menu Commands](#menu-commands)  
[Known Bugs](#known-bugs)  

---
## Description

_Wecome to Pierre's Bakery. Feel free to ask our lovely staff about our daily deals, what's fresh from the ovens, or just stop by to see a friendly face._

---
## Technologies Used

* _C#_
* _.NET_

---
## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Place files in a folder named `Bakery.Solution`
    <pre>Bakery.Solution
    ├── Bakery
    └── Bakery.Tests</pre>
<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>Bakery.Solution
   ├── <strong>Bakery</strong>
   └── Bakery.Tests</pre>

Run `$ dotnet run` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>Bakery.Solution
    ├── Bakery
    └── <strong>Bakery.Tests</strong></pre>

Run `$ dotnet restore` in the console, then 
Run `$ dotnet test` in the console

</details>
<br>

This program was built using *[Microsoft .NET SDK 5.0.401](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)*, and may not be compatible with other versions. Your milage may vary.

---
## Menu Commands
To buy bread:
* Loaf
* Bread(s)

To buy pastries:
* Pastry
* Doughnut(s)
* Bear Claw
* Beignet
* Danish

To See Today's Deals:
* Sale
* Coupon
* Deal(s)

To see what's available and prices:
* Menu
* Option(s)
* Inventory
* Price

To leave without buying anything:
* Bye
* Exit
* Leave
* Esc

_Note: Commands are not case sensitive. Random strings of characters may result in an undesired menu option._

---
## Known Bugs

* _Shows warning "Assignment made to same variable" for lines 43 and 63_
* _Pressing Enter without antering an option leads to the bread menu_ 