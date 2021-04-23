import { Person, Name } from "src/models";
import { getPerson } from "./calls/getPerson";
import { IPersonApi } from "./IPersonApi";

export class PersonApi implements IPersonApi {
    getPerson = getPerson;
    getName(): Promise<Name> {
        throw new Error("Method not implemented.");
    }    
}