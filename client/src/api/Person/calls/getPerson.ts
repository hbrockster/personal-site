import axios from "axios";
import { Person } from "@/models";

export async function getPerson(): Promise<Person> {
  const result = await axios({
    method: 'GET',
    url: 'api/person'
});
return new Person(result.data);
}
