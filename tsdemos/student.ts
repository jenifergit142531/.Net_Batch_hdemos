

//create class
class Student
{
    //variable declarations 
    public studentId:number;
    public studentName:string;
    private feeDetails:number;
    public s:string;
    // define constructor - initialize the object 
    constructor(id:number,name:string,fee:number)
    {
       this.studentId=id;
       this.studentName=name;
       this.feeDetails=fee;
    }
  
    //Create a display function
    public display()
    {
        console.log(`${this.studentName} with the student Id 
        ${this.studentId} paid the fees of Rs.${this.feeDetails}     
        `);
    }
}
//implement inheritance
class Department extends Student{
    public department:string;
    constructor(id:number,name:string,fee:number,dept:string)
    {
      super(id,name,fee);
      this.department=dept;
    }

    public show():void{
        console.log(`${this.studentName} with the student Id 
        ${this.studentId} is from the ${this.department} department 
        `);
    }
}
//create a object
//let student1:Student=new Student(101,"Jeni",25000);
//student1.display();
let student1:Student=new Student(101,"Jeni",25000);


//let dept1:Department=new Department(101,"jeni",25000,"Science");
//dept1.show();