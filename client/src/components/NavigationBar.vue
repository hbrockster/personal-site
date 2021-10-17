<template>
  <div class="nav-bar">
    <div class="nav-bar__left">
      <div class="nav-bar__logo">
        { <span class="nav-bar__intials">HB</span> }
      </div>
    </div>
    <div class="nav-bar__right">
      <a href="#about" class="nav-bar__link">
        <span class="nav-bar__link-number">01. </span>
        About
      </a>
      <a href="#skills" class="nav-bar__link">
        <span class="nav-bar__link-number">02. </span>
        Skills
      </a>
      <a href="#work-xp" class="nav-bar__link">
        <span class="nav-bar__link-number">03. </span>
        Work XP
      </a>
      <a href="#projects" class="nav-bar__link">
        <span class="nav-bar__link-number">04. </span>
        Projects
      </a>
      <a href="#contact" class="nav-bar__link">
        <span class="nav-bar__link-number">05. </span>
        Contact
      </a>
      <button data-hover="Download" class="nav_bar-button"><div>Resume</div></button>
    </div>
  </div>
</template>

<script>
import { Component, Vue } from 'vue-property-decorator';

@Component({})
export default class NavigationBar extends Vue {
}
</script>

<style>
.nav-bar {
  height: 3rem;
  background: #101314;
  position: fixed;
  top: 0;
  width: 100%;
  opacity: 0.75;
  box-shadow: 8px 0 11px 6px #171818;
  position: fixed;
  display: flex;
  padding-bottom: 0.5rem;
  padding-top: 0.7rem;
  align-items: flex-end;
  right: 0;
  left: 0;
  justify-content: space-between;
  backdrop-filter: blur(0.5rem);
}
.nav-bar__left {
  align-items: center;
  padding-left: 1rem;
  background: #101314;
  display: flex;
  align-self: center;
}
.nav-bar__logo {
  background: inherit;
  font-size: 1.5rem;
  transition: all 300ms;
  cursor: default;
}
.nav-bar__logo:hover {
  font-size: 2rem;
}
.nav-bar__intials {
  background: inherit;
  font-size: 1.5rem;
  transition: all 300ms;
  cursor: pointer;
}
.nav-bar__intials:hover {
  color: #cbffe5;
  font-size: 2rem;
}
.nav-bar__intials:active {
  color: #00cccc;
}
.nav-bar__right {
  margin-right: 2rem;
  background: inherit;
}
.nav-bar__link {
  text-decoration: none;
  margin: 0.5rem;
  font-size: 0.8rem;
  transition: all 300ms;
  background: inherit;
}
.nav-bar__link-number {
  color: #75ebb0;
  font-size: 0.8rem;
  background: inherit;
}
.nav-bar__link:hover {
  color: #cbffe5;
  font-size: 1.2rem;
}

.nav_bar-button:hover {
  cursor: pointer;
  background-color: #1e4632;
}
.nav_bar-button {
  background: transparent; 
  outline: none;
  position: relative;
  border: 2px solid #4caf50;
  padding: 15px 30px;
  overflow: hidden;
  border-radius: 0.2rem;
  transition: all 300ms;
}
.nav_bar-button:hover:before {
  opacity: 1; 
  transform: translate(0,0);
}
.nav_bar-button:before {
  content: attr(data-hover);
  position: absolute;
  top: 1.1em; left: 0;
  width: 100%;
  font-size: .9rem;
  opacity: 0;
  transform: translate(-100%,0);
  transition: all .3s ease-in-out;
}
.nav_bar-button:hover div {
  opacity: 0;
  transform: translate(100%,0);
}
.nav_bar-button div {
  font-size: .9rem;
  transition: transform .3s ease-in-out;
  background: inherit;
   background-color: inherit;
}
</style>
