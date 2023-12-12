export class PersonelModel{
    id: number = 0;
    firstname: string = "";
    lastname: string = "";
    profession: ProfessionType = "Software";
    salary: number = 11250;
}

export type ProfessionType = 
        "Software" | 
        "Accounting" | 
        "Cleaner"