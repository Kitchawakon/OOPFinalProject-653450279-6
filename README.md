# OOPFinalProject-653450279-6

ความเป็นมาของโปรแกรม
 - เกิดจากการที่เพื่อนคนหนึ่งที่เป็นพ่อค้าในเกมๆหนึ่งที่ต้องมีการจดไอเท็มในเกมอยู่เสมอ


วัตถุประสงค์ของโปรแกรม
 - มีวัตถุประสงค์ในการทำให้โปรแกรมนี้เป็นโปรแกรมในการจดบึนทึก รายการ Item ภายในเกมๆหนึ่ง (ขอไม่บอกชื่อเกม เพราะเขาไม่ได้จ่าย)


โครงสร้างของโปรแกรม (Class diagram) Mermaid 
```mermaid
classDiagram
    ClassAdmin --|> LoginSystem
    ClassItem --|> LoginSystem
    ClassAdmin:
    +NameAdmin: string
    +PassWord: string
    LoginSystem:
    +Login(string adminname, string password): bool
    ClassItem:
    +CharacterName: string
    +IDGame: string
    +Server: string
    +ItemName: string
    +ItemNumber: int
```


ชื่อของผู้พัฒนาโปรแกรม
 - นายกฤตชวกร ชวลิตกิตติวงศ์ รหัสนักศึกษา 653450279-6
