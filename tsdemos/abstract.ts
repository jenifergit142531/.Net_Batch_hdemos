
//abstract class
abstract class Employee
{
    constructor(private fname:string,private lname:string)
    {

    }
//abstract method 

    abstract getSalary():number;

    //concrete method
    compensationStatement():string{
        return `${this.fname} makes a salary of Rs.${this.getSalary()}
         for the month of december 2022`;
    }
}

//single inheritance

class FullTimeEmployee extends Employee
{
    constructor(fname:string,lname:string,private salary:number,private bonus:number){
        super(fname,lname);

    }

    public getSalary(): number {
        return this.salary+this.bonus;
    }
}

//Hierarchial inheritance 

class ContractEmployee extends Employee
{
    constructor(fname:string,lname:string,private rate:number,private hours:number)
    {
        super(fname,lname);
    }

    public getSalary(): number {
        return this.rate*this.hours;
    }
}


//Create objects

let employee1 = new FullTimeEmployee("Amy","Steven",150000,25000);
console.log(employee1.compensationStatement());

let employee2=new ContractEmployee("Peter","Jackson",40,2000);
console.log(employee2.compensationStatement());