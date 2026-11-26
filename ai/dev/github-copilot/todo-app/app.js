const form = document.querySelector('#todo-form');
const input = document.querySelector('#todo-input');
const list = document.querySelector('#todo-list');
const count = document.querySelector('#task-count');
const emptyState = document.querySelector('#empty-state');

function updateListState() {
  const total = list.children.length;
  count.textContent = `${total} ${total === 1 ? 'ITEM' : 'ITEMS'}`;
  emptyState.hidden = total !== 0;
}

form.addEventListener('submit', (event) => {
  event.preventDefault();
  const task = input.value.trim();
  if (!task) {
    input.value = '';
    input.focus();
    return;
  }

  const item = document.createElement('li');
  item.className = 'todo-item';

  const dot = document.createElement('span');
  dot.className = 'todo-dot';
  dot.setAttribute('aria-hidden', 'true');

  const text = document.createElement('span');
  text.className = 'todo-text';
  text.textContent = task;

  const remove = document.createElement('button');
  remove.className = 'remove-button';
  remove.type = 'button';
  remove.setAttribute('aria-label', `Remove ${task}`);
  remove.innerHTML = '<svg viewBox="0 0 24 24" fill="none" aria-hidden="true"><path d="M4 7h16M9 7V4h6v3m3 0-1 13H7L6 7m4 4v5m4-5v5" stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/></svg>';
  remove.addEventListener('click', () => {
    item.remove();
    updateListState();
    input.focus();
  });

  item.append(dot, text, remove);
  list.append(item);
  input.value = '';
  updateListState();
  input.focus();
});
