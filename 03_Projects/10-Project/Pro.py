import matplotlib.pyplot as plt
import networkx as nx
from heapq import heappush, heappop
import time

# --------------------------------------
# 1) original graph
# --------------------------------------
def create_graph():
    return {
        'A': {'J': 8, 'C': 10},
        'B': {'C': 3, 'D': 10, 'J': 9},
        'C': {'A': 10, 'B': 3, 'D': 12},
        'D': {'C': 12, 'B': 10, 'H': 5},
        'E': {'G': 6, 'H': 15, 'I': 8},
        'F': {'G': 7, 'J': 5},
        'G': {'F': 7, 'H': 11, 'E': 6},
        'H': {'D': 5, 'E': 15, 'G': 11, 'I': 5},
        'I': {'E': 8, 'H': 5},
        'J': {'A': 8, 'B': 9, 'F': 5},
    }

# --------------------------------------
# 2) Visualization function
# --------------------------------------
def draw_graph(G, pos, dist, current=None, updated_nodes=None, finalized=None, pause=1):
    colors = []

    for n in G.nodes():
        if n == current:
            colors.append("green")      # node being processed
        elif finalized and n in finalized:
            colors.append("skyblue")    # finalized shortest-path nodes
        elif updated_nodes and n in updated_nodes:
            colors.append("yellow")     # nodes updated in this step
        else:
            colors.append("white")

    plt.figure(figsize=(10,6))
    nx.draw(G, pos, with_labels=True, node_color=colors, 
            node_size=1200, font_size=12, font_weight='bold', edgecolors='black')

    edge_labels = nx.get_edge_attributes(G, 'weight')
    nx.draw_networkx_edge_labels(G, pos, edge_labels=edge_labels)

    # show distance table
    title = "Current Distances:\n"
    for k,v in dist.items():
        t = "∞" if v == float('inf') else str(v)
        title += f"{k}: {t}   "
    plt.title(title)

    plt.show()
    time.sleep(pause)

# --------------------------------------
# 3) Dijkstra + Visualization
# --------------------------------------
def dijkstra_visual(graph, source, target):
    dist = {n: float('inf') for n in graph}
    prev = {n: None for n in graph}
    dist[source] = 0

    heap = [(0, source)]
    finalized = set()

    # Create GraphX structure
    G = nx.Graph()
    for u in graph:
        for v,w in graph[u].items():
            G.add_edge(u, v, weight=w)

    # layout fixed
    pos = nx.spring_layout(G, seed=42)

    draw_graph(G, pos, dist, current=None)

    # Start Dijkstra
    while heap:
        d, u = heappop(heap)
        if u in finalized:
            continue

        finalized.add(u)
        draw_graph(G, pos, dist, current=u, finalized=finalized)

        if u == target:
            break

        updated = []
        for v, w in graph[u].items():
            nd = d + w
            if nd < dist[v]:
                dist[v] = nd
                prev[v] = u
                updated.append(v)
                heappush(heap, (nd, v))

        draw_graph(G, pos, dist, current=u, updated_nodes=updated, finalized=finalized)

    return dist, prev

# --------------------------------------
# 4) Construct shortest path
# --------------------------------------
def reconstruct_path(prev, source, target):
    if prev[target] is None and source != target:
        return None
    path = []
    node = target
    while node:
        path.append(node)
        node = prev[node]
    return list(reversed(path))

# --------------------------------------
# 5) Final visualization (path highlight)
# --------------------------------------
def draw_final(G, pos, path):
    colors = ["lightgreen" if n in path else "white" for n in G.nodes()]
    widths = [4 if (u in path and v in path and abs(path.index(u) - path.index(v)) == 1) else 1
              for u,v in G.edges()]
    
    plt.figure(figsize=(10,6))
    nx.draw(G, pos, with_labels=True, node_color=colors, 
            node_size=1200, font_size=12, font_weight="bold", width=widths, edgecolors="black")
    plt.title("Final Shortest Path: " + " -> ".join(path))
    edge_labels = nx.get_edge_attributes(G, 'weight')
    nx.draw_networkx_edge_labels(G, pos, edge_labels=edge_labels)
    plt.show()

# --------------------------------------
# 6) Run Visualization
# --------------------------------------
def visualize(source="A", target="H"):
    graph = create_graph()
    dist, prev = dijkstra_visual(graph, source, target)

    path = reconstruct_path(prev, source, target)

    # build graphX again
    G = nx.Graph()
    for u in graph:
        for v,w in graph[u].items():
            G.add_edge(u, v, weight=w)
    pos = nx.spring_layout(G, seed=42)

    draw_final(G, pos, path)

    print("Shortest path:", " -> ".join(path))
    print("Cost:", dist[target])


# Example
visualize("A", "I")
