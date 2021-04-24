import { Person } from "@/models";

export interface IPersonApi {
    getPerson(): Promise<Person>;
}