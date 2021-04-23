import { Person } from "@/models";
import { IPersonApi } from "./IPersonApi";

export class PersonApi implements IPersonApi {
    getPerson(): Promise<Person> {
        throw new Error("Method not implemented.");
    }
    
}