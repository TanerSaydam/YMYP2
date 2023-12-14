export class PersonelModel{
    constructor(){
        this.id = new Date().toString();
    }
    id: string;
    firstName : string = "";
    lastName: string = "";
    profession: ProfessionType = "Software";
}

export type ProfessionType = "Software" | "Accounting" | "Teacher"