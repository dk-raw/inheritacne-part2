# C# Class Inheritance (REFERE TO THE PART 1)

<i>this is the first example out of three for the class inheritance in C#</i>

<hr />

### Code explanation:

There is one class named ```Person``` which has 6 properties: <br />
``` C#
class Person
    {
        public string Name { get; set; } //Name
        public int Age { get; set; } //Age
        public int Salary { get; set; }  //Salary
        public string Status { get; set; } //Status
        public string Building { get; set; } //Building
        public double Score { get; set; } //Score
        }
```
This class includes general info about hospital workers (from surgeons to cleaners)

Then there is a class named ```Doctor``` that <b><i>inherits</i></b> all of the properties that the ```Person``` class has and adds another class specific property <br/>
``` C#
    class Doctor : Person
    {
        public string Degree { get; set; } //Doctor specific property
    }
```
After that comes a class named ```Nurses``` that also inherits its basic properties from the ```Person``` class and adds one class sepcific property <br/>
``` C#
    class Nurse : Person 
    {
        public int Experiance { get; set; } //Nurse specific class
    }
```
<hr/>

All the properties in the ```Person``` class are accessible through the other classes <br/>

``` C#
Doctor d1 = new Doctor();
            d1.Name = "John Doe"; //the doctor has access to all the properties in the Person class and it' s own property
            d1.Age = 42;
            d1.Salary = 70000;
            d1.Status = "ACTIVE";
            d1.Building = "Operating Room";
            d1.Score = 10;
            d1.Degree = "Berlin Universtiy of Applied Sciences";
```

<hr />
To make a class inherit properties from an other class you will put a <b>:</b> and then the class name after the name of the class:

``` C#
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public string Building { get; set; }
        public double Score { get; set; }
    }
    class Doctor : Person //This is how you inherit properties
    {
    }
```
