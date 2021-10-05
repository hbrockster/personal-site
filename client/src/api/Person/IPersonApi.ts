import { Person, Name } from "@/models";

export interface IPersonApi {
    getPerson(): Promise<Person>;
    getName(): Promise<Name>;
}