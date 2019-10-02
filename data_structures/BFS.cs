
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
70
71
72
73
74
75
76
77
78
79
80
81
82
83
84
85
86
87
88
89
90
91
92
93
94
95
96
97
98
99
100
101
102
103
104
105
106
107
108
109
110
111
112
113
114
115
116
117
118
119
120
121
122
123
124
125
126
127
128
129
130
131
132
133
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirst
{
    class Program
    {
        public class Employee
        {
            public Employee(string name)
            {
                this.name = name;
            }

            public string name { get; set; }
            public List<Employee> Employees
            {
                get
                {
                    return EmployeesList;
                }
            }

            public void isEmployeeOf(Employee p)
            {
                EmployeesList.Add(p);
            }

            List<Employee> EmployeesList = new List<Employee>();

            public override string ToString()
            {
                return name;
            }
        }

        public class BreadthFirstAlgorithm
        {
            public Employee BuildEmployeeGraph()
            {
                Employee Eva = new Employee("Eva");
                Employee Sophia = new Employee("Sophia");
                Employee Brian = new Employee("Brian");
                Eva.isEmployeeOf(Sophia);
                Eva.isEmployeeOf(Brian);

                Employee Lisa = new Employee("Lisa");
                Employee Tina = new Employee("Tina");
                Employee John = new Employee("John");
                Employee Mike = new Employee("Mike");
                Sophia.isEmployeeOf(Lisa);
                Sophia.isEmployeeOf(John);
                Brian.isEmployeeOf(Tina);
                Brian.isEmployeeOf(Mike);

                return Eva;
            }

            public Employee Search(Employee root, string nameToSearchFor)
            {
                Queue<Employee> Q = new Queue<Employee>();
                HashSet<Employee> S = new HashSet<Employee>();
                Q.Enqueue(root);
                S.Add(root);

                while (Q.Count > 0)
                {
                    Employee e = Q.Dequeue();
                    if (e.name == nameToSearchFor)
                        return e;
                    foreach (Employee friend in e.Employees)
                    {
                        if (!S.Contains(friend))
                        {
                            Q.Enqueue(friend);
                            S.Add(friend);
                        }
                    }
                }
                return null;
            }

            public void Traverse(Employee root)
            {
                Queue<Employee> traverseOrder = new Queue<Employee>();

                Queue<Employee> Q = new Queue<Employee>();
                HashSet<Employee> S = new HashSet<Employee>();
                Q.Enqueue(root);
                S.Add(root);

                while (Q.Count > 0)
                {
                    Employee e = Q.Dequeue();
                    traverseOrder.Enqueue(e);

                    foreach (Employee emp in e.Employees)
                    {
                        if (!S.Contains(emp))
                        {
                            Q.Enqueue(emp);
                            S.Add(emp);
                        }
                    }
                }

                while (traverseOrder.Count > 0)
                {
                    Employee e = traverseOrder.Dequeue();
                    Console.WriteLine(e);
                }
            }
        }

        static void Main(string[] args)
        {
            BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
            Employee root = b.BuildEmployeeGraph();
            Console.WriteLine("Traverse Graph\n------");
            b.Traverse(root);

            Console.WriteLine("\nSearch in Graph\n------");
            Employee e = b.Search(root, "Eva");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
            e = b.Search(root, "Brian");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
            e = b.Search(root, "Soni");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
        }
    }
}