<template>
  <div id="app">
    <NavigationBar />
    <Introduction />
    <About/>
    <Skills/>
    <!-- <Section class="section-reset" name="Skills"  number="01."/>
    <Section name="Skills" number="01."/> -->
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import NavigationBar from '@/components/NavigationBar.vue';
import Introduction from '@/components/Introduction.vue';
import Section from '@/components/Section.vue';
import About from '@/components/About.vue';
import Skills from '@/components/Skills.vue';

@Component({ components: { NavigationBar, Introduction, Section, About, Skills }})
export default class App extends Vue {
}
</script>

<style>
body { 
  margin: 0;
}
#app {
    font-family: Space Mono, Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    margin-top: 60px;
}
* {
    background: #272727;
    color: #67ff88;
    font-size: 16px;
}
.fancy-button {
  position: relative;
  padding: 1em 1.5em;
  border: none;
  background-color: transparent;
  cursor: pointer;
  outline: none;
  font-size: 18px;
  top: 0.3rem;
}
.fancy-button-bars {
    color: #67ff88;
}
.fancy-button-bars::after,
.fancy-button-bars::before {
  content: '';
  display: block;
  position: absolute;
  width: 20%;
  height: 20%;
  border: 2px solid;
  transition: all 0.6s ease;
  border-radius: 2px;
}
.fancy-button-bars::after {
  bottom: 0;
  right: 0;
  border-top-color: transparent;
  border-left-color: transparent;
  border-bottom-color: #4caf50;
  border-right-color: #4caf50;
}
.fancy-button-bars::before {
  top: 0;
  left: 0;
  border-bottom-color: transparent;
  border-right-color: transparent;
  border-top-color: #4caf50;
  border-left-color: #4caf50;
}
.fancy-button-bars:hover:after,
.fancy-button-bars:hover:before {
  border-bottom-color: #4caf50;
  border-right-color: #4caf50;
  border-top-color: #4caf50;
  border-left-color: #4caf50;
  width: 100%;
  height: 100%;
}
</style>
