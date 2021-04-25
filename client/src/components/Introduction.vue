<template>
  <div id="intro" class="intro">
    <div class="intro__msg">
      Hello, my name is
    </div>
    <div class="intro__name">Hunter Brock</div>
    <p>
      I am a full stack developer/software engineer based in Florida with a
      large set of <a href="#skills">skills</a> in front and back end web
      development.
    </p>
    <!-- <button class="button">Contact</button> -->
    <!-- <a href="#contact" class="button">Contact</a> -->
    <button class="fancy-button fancy-button-bars" @click="getPerson()">Contact</button>
  </div>
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';

@Component({ })
export default class Introduction extends Vue {
  name = '';
  created(): void {
    console.log(this.name);
  }
  async getPerson(): Promise<void> {
    console.log(this.$personApi);
  }
}
</script>
<style>
.intro {
  text-align: left;
  height: 60rem;
  margin: 20rem 10rem;
}
.intro__msg {
  color: #cbffe5;
}
.intro__name {
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
