<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <button @click="getPerson()">DO CALL</button>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import { PersonApi } from '@/api/Person';

@Component({})
export default class HelloWorld extends Vue {
  @Prop() private msg!: string;
  getPerson(): void {
    const personApi = new PersonApi()
    personApi.getPerson();
    console.log("Getting a person");
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
