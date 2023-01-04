var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//create class
var Student = /** @class */ (function () {
    // define constructor - initialize the object 
    function Student(id, name, fee) {
        this.studentId = id;
        this.studentName = name;
        this.feeDetails = fee;
    }
    Student.prototype.getDetails = function () {
        var s = prompt("Enter the id");
        console.log(s);
    };
    //Create a display function
    Student.prototype.display = function () {
        console.log("".concat(this.studentName, " with the student Id \n        ").concat(this.studentId, " paid the fees of Rs.").concat(this.feeDetails, "     \n        "));
    };
    return Student;
}());
//implement inheritance
var Department = /** @class */ (function (_super) {
    __extends(Department, _super);
    function Department(id, name, fee, dept) {
        var _this = _super.call(this, id, name, fee) || this;
        _this.department = dept;
        return _this;
    }
    Department.prototype.show = function () {
        console.log("".concat(this.studentName, " with the student Id \n        ").concat(this.studentId, " is from the ").concat(this.department, " department \n        "));
    };
    return Department;
}(Student));
//create a object
//let student1:Student=new Student(101,"Jeni",25000);
//student1.display();
var student1 = new Student(101, "Jeni", 25000);
student1.getDetails();
//let dept1:Department=new Department(101,"jeni",25000,"Science");
//dept1.show();
