// Base class: Person
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    getDetails() {
        return `Name: ${this.name}, Age: ${this.age}`;
    }
}

// Derived class: Student
class Student extends Person {
    constructor(name, age, studentId, courses) {
        super(name, age); // Call the parent class constructor
        this.studentId = studentId;
        this.courses = courses; 
    }

    // Polymorphism: Overriding the getDetails method
    getDetails() {
        return `${super.getDetails()}, Student ID: ${this.studentId}, Courses: ${this.courses.join(", ")}`;
    }

    // Encapsulation: Private property
    #grades = {}; 

    // Encapsulation: Method to set grades
    setGrade(course, grade) {
        if (this.courses.includes(course)) {
            this.#grades[course] = grade;
        } else {
            console.log(`Student is not enrolled in ${course}`);
        }
    }

    // Encapsulation: Method to get grades
    getGrade(course) {
        return this.#grades[course] || 'No grade';
    }
}

// OOPs concepts
const student1 = new Student('Arvind Mali', 23, '205121027', ['DSA', 'OOPS','CN']);
console.log(student1.getDetails()); 

student1.setGrade('DSA', 'A');
student1.setGrade('OOPS', 'B');
student1.setGrade('CN', 'D');
console.log(`Grade in DSA: ${student1.getGrade('DSA')}`);
console.log(`Grade in OOPS: ${student1.getGrade('OOPS')}`);

student1.setGrade('CN', 'C'); 

console.log(student1.getGrade('CN')); 
