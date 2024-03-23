 ความเป็นมา
โปรเจ็คการเขียนโปรแกรมนี้ถูกสร้างขึ้นเพื่อแก้ปัญหาในโลกจริงที่เกี่ยวกับการขายสัตว์เลี้ยง โดยมีวัตถุประสงค์เพื่อพัฒนาแอปพลิเคชันที่จะช่วยให้ผู้ใช้สามารถดูข้อมูลเกี่ยวกับสัตว์เลี้ยง
ต่างๆ

วัตถุประสงค์
วัตถุประสงค์หลักของโปรเจ็คเพื่อ 
1. เพิ่มความสะดวกสบายในการซื้อขายสัตว์เลี้ยง
2. เพื่อพัฒนาการเขียนโปรแกรมของตัวเอง

โครงสร้างโปรแกรม
    หน้าหลัก 
    ฟอร์มแสดงข้อมูลสัตว์เลี้ยง
    ฟอร์มแสดงรายงาน
    ฟอร์มเพิ่มข้อมูลสัตว์เลี้ยง


 ผู้พัฒนาโปรแกรม
    นาย ชูเกียรติ คำมณีจันทร์
```mermiad
classdiagram
    Animal <|-- PoultryAnimal
    Animal : +string name
    Animal : +string gene
    Animal: +int price
    class ReptileAnimal{
      +ReptileAnimal()
    }
    class PoultryAnimal{
      +PoultryAnimal()
    }
    class Zebra{
      +LandAnimal()
    }
    class Form1{
        -LandAnimal dog
        -LandAnimal dog2
        -LandAnimal cat
        -ReptileAnimal snake
        -ReptileAnimal snake2
        -ReptileAnimal chameleon
        -PoultryAnimal bird
        -PoultryAnimal bird2
        -PoultryAnimal bird3

        -Poultrytext()
        -Hidehomepage()
        -hide123()
        -hide456()
        -hide789()
        -Hidehomepage2()
        -Showinformationland()
        -ShowinformationReptail()   
        -ShowinformationPoultry()
        -pictureBox1_Click()
        -label1_Click()
        -button1_Click()
        -button2_Click()  
        -button3_Click()
        -showsard2_Click()
        -label12_Click()
        -label11_Click()
        -label13_Click()
        -sale1_Click()
        -sale3_Click()
        -sale2_Click()
        -sale4_Click()
        -sale5_Click()
        -sale6_Click()
        -sale7_Click()
        -sale8_Click()
        -sale9_Click()
        -buttonback_Click()
        -button4_Click()  
    }
``
