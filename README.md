# OOPFinalProject-653450279-6

ความเป็นมาของโปรแกรม
 - เกิดจากการที่เพื่อนคนหนึ่งที่เป็นพ่อค้าในเกมๆหนึ่งที่ต้องมีการจดไอเท็มในเกมอยู่เสมอ


วัตถุประสงค์ของโปรแกรม
 - มีวัตถุประสงค์ในการทำให้โปรแกรมนี้เป็นโปรแกรมในการจดบึนทึก รายการ Item ภายในเกมๆหนึ่ง (ขอไม่บอกชื่อเกม เพราะเขาไม่ได้จ่าย)


โครงสร้างของโปรแกรม (Class diagram) Mermaid 
```mermaid
classDiagram    
    class ClassAdmin {
        <<Entity>>
        +NameAdmin: string
        +PassWord: string
    }

    class LoginSystem {
        <<Service>>
        -Admin: List<ClassAdmin>
        +Login(adminname: string, password: string): bool
    }

    class ClassItem {
        <<Entity>>
        +CharacterName: string
        +IDGame: string
        +Server: string
        +ItemName: string
        +ItemNumber: int
        +ClassItem(nameC: string, idG: string, ser: string, itemname: string, itemnum: int)
    }
```
```mermaid
classDiagram
 direction RT
 class Restaurant{
 -login():void
}
class Restaurant1{
 -cheakin():void
 -cheaout():void
 -Save():void
 -Clear():void
 -fooditems():void
 -exitProgram():void
}
 class Restaurant2{
 -discountcode():void
 -pay():void
 -back():void
 }
 class Checkpay{
 -discountCode:string
 -minimumPice:double
 +creat(double min):void
 +getDiscount():void
 }
 class Buy{
 -totalPice:double
 +Bill(double pay, double getmoney):void
 +restaurantBill():double
  }
  class Class{
  -name, customerNumber, mail, day, seat:string
  -time:int
  +Class(string name, string cutomerNumber, string mail, string day, int time, string seat)
  }
  Pay -- Checkpay
  Pay -- Buy
  Pay -- Class
```  


ชื่อของผู้พัฒนาโปรแกรม
 - นายกฤตชวกร ชวลิตกิตติวงศ์ รหัสนักศึกษา 653450279-6
