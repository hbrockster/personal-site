import { Person, Name } from "src/models";
import { IPersonApi } from "./IPersonApi";

export class PersonApi implements IPersonApi {
    getPerson(): Promise<Person> {
        throw new Error("Method not implemented.");
    }
    getName(): Promise<Name> {
        throw new Error("Method not implemented.");
    }
    
}