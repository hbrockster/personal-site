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
    <button class="button" @click="getPerson()">Contact</button>
  </div>
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';

@Component({})
export default class Introduction extends Vue {
}
</script>
<style>
.intro {
  text-align: left;
  height: 60rem;
}
.intro__msg {
  color: #cbffe5;
}
.intro__name {
  font-size: 4rem;
  font-weight: 600;
}
</style>
