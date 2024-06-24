// function employeeDetails(employeeName,employeeSalary){
//     this.employeeName=employeeName
//     this.employeeSalary=employeeSalary
//     this.displayDetails=()=>{
//         return "Employee name is "+this.employeeName+" and salary is "+this.employeeSalarya
//     }
// }
// const firstEmployee= new employeeDetails('John',20000)
// const secondEmployee= new employeeDetails('Mary',30000)

// // console.log(firstEmployee.displayDetails())
// // console.log(secondEmployee.displayDetails())
// console.log(firstEmployee.employeeName)
// console.log(secondEmployee.employeeName)
// class Vehicle
// {
//     constructor(vehicleType,modelName)
//     {
//         this.vehicleType=vehicleType
//         this.modelName=modelName
//     }
//     displayDetails()
//     {
//         console.log(`The type of Vehicle is ${this.vehicleType} and the model is ${this.modelName}`)
//     }
// }
// let vehicleOne=new Vehicle('Car','Audi')

// vehicleOne.displayDetails()
//   {
//       constructor(name,designation,salary)
//       {
//           this.name=name
//           this.designation=designation
//           this.salary=salary
//       }
//       greet()
//       {
//           console.log("Hello welcome iam communicationg through parent class")
//       }
//   }

//   class Manager extends Employee
//   {
//       constructor(name,salary,designation,empId)
//       {
//           super(name,designation,salary)
//           this.empId=empId
//       }
//       displayInformation()
//       {
//           console.log(`The name of employee is ${this.name} salary is ${this.salary}
//               Designation is ${this.designation} and Employee ID is ${this.empId}`)
//       }
//   }

//   let manager=new Manager('John','HR Manager',50000,100)
//   manager.greet()
//   manager.displayInformation()



class shape{

      area(value1,value2){
        console.log(value1*value2);
      }
}

class rectangle extends shape{
    area(value1,value2){
       super.area(value1,value2);
      }
}

let rec = new rectangle();
rec.area(2,5);

