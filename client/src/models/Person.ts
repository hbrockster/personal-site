import { Name } from "./Name";

export class Person {
  name?: Name;
  cellPhoneNumber: string | null = null;
  emailAddress: string | null = null;
  iD: string | null = null;
  bio?: string | null = null;

  constructor(init?: Partial<Person>) {
    Object.assign(this, init);
    this.name = new Name(this.name);
  }
}