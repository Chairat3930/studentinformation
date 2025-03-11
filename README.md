# studentinformation
โปรแกรมนี้เป็นระบบบันทึกข้อมูลนักศึกษาสำหรับอาจารย์ที่ปรึกษา ซึ่งสามารถ:

บันทึกข้อมูลนักศึกษา (รหัสนักศึกษา, ชื่อ, สาขา, เกรด, อาจารย์ที่ปรึกษา)

แสดงรายชื่อนักศึกษาทั้งหมด

แสดงรายชื่อนักศึกษาของอาจารย์ที่ปรึกษา

ค้นหานักศึกษาที่มีเกรดสูงสุด

ข้อมูลผู้พัฒนา

ชื่อ:ชัยรัตน์ วงศ์รัตนชัย

รหัสนักศึกษา:673450393-0

หลักการ OOP ที่ใช้ในโปรแกรม

1. Encapsulation (การห่อหุ้มข้อมูล)

2.คลาส Student และ Advisor ซ่อนข้อมูลและใช้เมธอดเพื่อเข้าถึงข้อมูลแทนการเข้าถึงโดยตรง
ข้อมูลภายในคลาสถูกจัดการผ่าน Constructor และ Method

3. Abstraction (การซ่อนรายละเอียด)
คลาส Student และ Advisor มีเฉพาะฟังก์ชันที่จำเป็นสำหรับการทำงานของโปรแกรม
ไม่จำเป็นต้องรู้รายละเอียดภายในของการทำงานของคลาสเหล่านี้

4. Inheritance (การสืบทอดคลาส)
สามารถเพิ่มคลาสย่อยเช่น GraduateStudent ที่สืบทอดจาก Student ได้ในอนาคต

5. Polymorphism (พหุนาม)
สามารถใช้เมธอด GetInfo() ในคลาส Student และ Advisor ได้โดยสามารถขยายได้ในอนาคต

```mermaid
classDiagram
    class Advisor {
        +string Name
        +string Department
        +List~Student~ Students
        +AddStudent(Student student)
    }

    class Student {
        +string ID
        +string Name
        +string Department
        +double Grade
        +Advisor Advisor
    }

    Advisor "1" -- "0..*" Student : advises


