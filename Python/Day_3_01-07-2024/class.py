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
    
# p1 = Person("John", 36)
p2 = Person("Arvind", 23,"CA",7)

# print(p1.name)
# print(p1.age)
print(p2.name)
print(p2.sub)
p2.myfunc()

print(p2)
del p2.age


class student:
  pass