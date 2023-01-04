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
//abstract class
var Employee = /** @class */ (function () {
    function Employee(fname, lname) {
        this.fname = fname;
        this.lname = lname;
    }
    //concrete method
    Employee.prototype.compensationStatement = function () {
        return "".concat(this.fname, " makes a salary of Rs.").concat(this.getSalary(), "\n         for the month of december 2022}");
    };
    return Employee;
}());
//single inheritance
var FullTimeEmployee = /** @class */ (function (_super) {
    __extends(FullTimeEmployee, _super);
    function FullTimeEmployee(fname, lname, salary, bonus) {
        var _this = _super.call(this, fname, lname) || this;
        _this.salary = salary;
        _this.bonus = bonus;
        return _this;
    }
    FullTimeEmployee.prototype.getSalary = function () {
        return this.salary + this.bonus;
    };
    return FullTimeEmployee;
}(Employee));
//Hierarchial inheritance 
var ContractEmployee = /** @class */ (function (_super) {
    __extends(ContractEmployee, _super);
    function ContractEmployee(fname, lname, rate, hours) {
        var _this = _super.call(this, fname, lname) || this;
        _this.rate = rate;
        _this.hours = hours;
        return _this;
    }
    ContractEmployee.prototype.getSalary = function () {
        return this.rate * this.hours;
    };
    return ContractEmployee;
}(Employee));
//Create objects
var employee1 = new FullTimeEmployee("Amy", "Steven", 150000, 25000);
console.log(employee1.compensationStatement());
var employee2 = new ContractEmployee("Peter", "Jackson", 40, 2000);
console.log(employee2.compensationStatement());
