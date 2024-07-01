class Person:
  def __init__(self, name, age,sub,g):
    self.name = name
    self.age = age
    self.sub = sub
    self.g= g
  def __str__(self):
    return f"{self.name}({self.age}) having {self.sub} with gardes {self.g}"
  def myfunc(self):
    print("Hello my name is " + self.name)

class Student(Person):
  def __init__(self, name, age,sub,g):
    # Person.__init__(self, name, age,sub,g)
    super().__init__( name, age,sub,g)
    self.graduate = True


st1=  Student("Arvind",23,"maths",8)
print(st1)