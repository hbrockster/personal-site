<template>
  <div id="intro" class="intro">
    <div class="intro__msg">
      Hello, my name is
    </div>
    <div class="intro__name">{{ name }}</div>
    <div class="intro__title">Software Engineer</div>
    <p>{{ person.bio }}</p>
    <a href="#contact" class="fancy-button fancy-button-bars">Contact</a>
  </div>
</template>
<script lang="ts">
import { Component, Provide, Vue } from 'vue-property-decorator';
import { Person } from '@/models';

@Component({ })
export default class Introduction extends Vue {
  person = new Person();
  created(): void {
    this.$personApi.getPerson().then(person => this.person = person);
  }
  get name(): string {
    const name = this.person?.name;
    return name?.first + ' ' + name?.last
  }
}
</script>
<style>
.intro {
  text-align: left;
  height: 60rem;
  margin: 20rem 10rem;
}
.intro p {
  margin-bottom: 2rem;
  max-width: 60%;
  line-height: 1.5rem
}
.intro__msg {
  color: #3c7c5c;
}
.intro__name {
  font-size: 4rem;
  font-weight: 600;
  color: #64ebd4;
}
.intro__title {
  font-size: 4rem;
  font-weight: 600;
}
.button {
    background-color: transparent;
    border: 0.125rem solid #4caf50;
    border-radius: 0.2rem;
    padding: 0.8rem 1.5rem;
    text-align: center;
    display: inline-block;
    font-size: 0.8rem;
    color: #75ebb0;
    cursor: pointer;
    transition: all 300ms;
    font-family: inherit;
    text-decoration: none;
    
  }
.button:hover {
  box-shadow: inset 0 0 0.7rem 0.4rem #cbffe5;
  font-size: 0.9rem;
}
</style>
