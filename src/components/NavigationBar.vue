<template>
  <div class="nav-bar">
    <div class="nav-bar__left"></div>
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
      <button class="nav-bar__button">Resume</button>
    </div>
  </div>
</template>

<script>
export default {
  name: "NavigationBar",
  props: {
    options: {
      type: Array,
      required: false
    }
  }
};
</script>

<style lang="scss">
.nav-bar {
  height: 3rem;
  background: #101314;
  position: fixed;
  top: 0;
  width: 100%;
  opacity: 0.8;
  box-shadow: 8px -9px 11px 6px #000000;
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
  //width: 10%;
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
.nav-bar__button {
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
}
.nav-bar__button:hover {
  //background-color: #cbffe5;
  //box-shadow: inset 0 0 0.7rem 0.4rem #cbffe5;
  box-shadow: 0 0 0.5rem #cbffe5;
  font-size: 0.9rem;
}
</style>
